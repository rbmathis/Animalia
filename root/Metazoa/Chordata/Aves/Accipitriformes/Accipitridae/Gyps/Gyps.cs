using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Gyps;

/// <summary>
/// Abstract class for Gyps (genus).
/// NCBI TaxId: 8965
/// </summary>
public abstract class Gyps : Accipitridae, IGyps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gyps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8965;

    /// <inheritdoc />
    public virtual string GenusName => "Gyps";

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
