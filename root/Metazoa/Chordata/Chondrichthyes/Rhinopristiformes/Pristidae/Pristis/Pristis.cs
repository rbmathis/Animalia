using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Pristidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Pristidae.Pristis;

/// <summary>
/// Abstract class for Pristis (genus).
/// NCBI TaxId: 55130
/// </summary>
public abstract class Pristis : Pristidae, IPristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55130;

    /// <inheritdoc />
    public virtual string GenusName => "Pristis";

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
