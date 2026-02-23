using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae.Heliornis;

/// <summary>
/// Abstract class for Heliornis (genus).
/// NCBI TaxId: 54368
/// </summary>
public abstract class Heliornis : Heliornithidae, IHeliornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heliornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54368;

    /// <inheritdoc />
    public virtual string GenusName => "Heliornis";

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
