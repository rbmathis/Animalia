using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Fregetta;

/// <summary>
/// Abstract class for Fregetta (genus).
/// NCBI TaxId: 37072
/// </summary>
public abstract class Fregetta : Procellariiformes, IFregetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fregetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37072;

    /// <inheritdoc />
    public virtual string GenusName => "Fregetta";

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
