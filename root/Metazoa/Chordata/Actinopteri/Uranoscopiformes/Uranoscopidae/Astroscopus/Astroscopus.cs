using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Astroscopus;

/// <summary>
/// Abstract class for Astroscopus (genus).
/// NCBI TaxId: 1206927
/// </summary>
public abstract class Astroscopus : Uranoscopidae, IAstroscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astroscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206927;

    /// <inheritdoc />
    public virtual string GenusName => "Astroscopus";

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
