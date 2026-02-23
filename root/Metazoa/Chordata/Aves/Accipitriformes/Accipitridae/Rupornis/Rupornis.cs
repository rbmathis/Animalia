using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Rupornis;

/// <summary>
/// Abstract class for Rupornis (genus).
/// NCBI TaxId: 3061038
/// </summary>
public abstract class Rupornis : Accipitridae, IRupornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rupornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3061038;

    /// <inheritdoc />
    public virtual string GenusName => "Rupornis";

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
