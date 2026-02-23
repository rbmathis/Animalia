using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Goura;

/// <summary>
/// Abstract class for Goura (genus).
/// NCBI TaxId: 115653
/// </summary>
public abstract class Goura : Columbidae, IGoura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115653;

    /// <inheritdoc />
    public virtual string GenusName => "Goura";

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
