using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Egretta;

/// <summary>
/// Abstract class for Egretta (genus).
/// NCBI TaxId: 56073
/// </summary>
public abstract class Egretta : Ardeidae, IEgretta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Egretta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56073;

    /// <inheritdoc />
    public virtual string GenusName => "Egretta";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
