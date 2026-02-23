using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Accipiter;

/// <summary>
/// Abstract class for Accipiter (genus).
/// NCBI TaxId: 8956
/// </summary>
public abstract class Accipiter : Accipitridae, IAccipiter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Accipiter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8956;

    /// <inheritdoc />
    public virtual string GenusName => "Accipiter";

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
