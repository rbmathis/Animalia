using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Pernis;

/// <summary>
/// Abstract class for Pernis (genus).
/// NCBI TaxId: 43550
/// </summary>
public abstract class Pernis : Accipitridae, IPernis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pernis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43550;

    /// <inheritdoc />
    public virtual string GenusName => "Pernis";

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
