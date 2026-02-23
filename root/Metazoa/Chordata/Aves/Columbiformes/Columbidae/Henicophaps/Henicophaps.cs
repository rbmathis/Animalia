using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Henicophaps;

/// <summary>
/// Abstract class for Henicophaps (genus).
/// NCBI TaxId: 444141
/// </summary>
public abstract class Henicophaps : Columbidae, IHenicophaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Henicophaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 444141;

    /// <inheritdoc />
    public virtual string GenusName => "Henicophaps";

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
