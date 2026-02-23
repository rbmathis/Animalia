using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Gorsachius;

/// <summary>
/// Abstract class for Gorsachius (genus).
/// NCBI TaxId: 752196
/// </summary>
public abstract class Gorsachius : Ardeidae, IGorsachius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gorsachius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 752196;

    /// <inheritdoc />
    public virtual string GenusName => "Gorsachius";

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
