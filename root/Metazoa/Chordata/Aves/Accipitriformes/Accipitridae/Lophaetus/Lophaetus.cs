using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Lophaetus;

/// <summary>
/// Abstract class for Lophaetus (genus).
/// NCBI TaxId: 321110
/// </summary>
public abstract class Lophaetus : Accipitridae, ILophaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321110;

    /// <inheritdoc />
    public virtual string GenusName => "Lophaetus";

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
