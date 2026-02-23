using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Metriopelia;

/// <summary>
/// Abstract class for Metriopelia (genus).
/// NCBI TaxId: 115676
/// </summary>
public abstract class Metriopelia : Columbidae, IMetriopelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metriopelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115676;

    /// <inheritdoc />
    public virtual string GenusName => "Metriopelia";

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
