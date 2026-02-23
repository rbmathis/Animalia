using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Harpagus;

/// <summary>
/// Abstract class for Harpagus (genus).
/// NCBI TaxId: 387841
/// </summary>
public abstract class Harpagus : Accipitridae, IHarpagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 387841;

    /// <inheritdoc />
    public virtual string GenusName => "Harpagus";

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
