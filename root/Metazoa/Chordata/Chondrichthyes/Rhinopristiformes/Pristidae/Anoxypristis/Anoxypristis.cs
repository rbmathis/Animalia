using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Pristidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Pristidae.Anoxypristis;

/// <summary>
/// Abstract class for Anoxypristis (genus).
/// NCBI TaxId: 117886
/// </summary>
public abstract class Anoxypristis : Pristidae, IAnoxypristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoxypristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117886;

    /// <inheritdoc />
    public virtual string GenusName => "Anoxypristis";

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
