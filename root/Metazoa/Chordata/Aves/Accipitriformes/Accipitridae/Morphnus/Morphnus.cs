using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Morphnus;

/// <summary>
/// Abstract class for Morphnus (genus).
/// NCBI TaxId: 252788
/// </summary>
public abstract class Morphnus : Accipitridae, IMorphnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morphnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 252788;

    /// <inheritdoc />
    public virtual string GenusName => "Morphnus";

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
