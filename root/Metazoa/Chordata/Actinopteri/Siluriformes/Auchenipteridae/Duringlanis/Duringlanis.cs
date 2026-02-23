using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Duringlanis;

/// <summary>
/// Abstract class for Duringlanis (genus).
/// NCBI TaxId: 2613931
/// </summary>
public abstract class Duringlanis : Auchenipteridae, IDuringlanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Duringlanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613931;

    /// <inheritdoc />
    public virtual string GenusName => "Duringlanis";

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
