using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Sarcogyps;

/// <summary>
/// Abstract class for Sarcogyps (genus).
/// NCBI TaxId: 43578
/// </summary>
public abstract class Sarcogyps : Accipitridae, ISarcogyps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcogyps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43578;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcogyps";

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
