using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Halichoeres;

/// <summary>
/// Abstract class for Halichoeres (genus).
/// NCBI TaxId: 51788
/// </summary>
public abstract class Halichoeres : Labridae, IHalichoeres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halichoeres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51788;

    /// <inheritdoc />
    public virtual string GenusName => "Halichoeres";

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
