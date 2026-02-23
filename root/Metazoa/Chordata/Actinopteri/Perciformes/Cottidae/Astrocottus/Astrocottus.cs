using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Astrocottus;

/// <summary>
/// Abstract class for Astrocottus (genus).
/// NCBI TaxId: 1633503
/// </summary>
public abstract class Astrocottus : Cottidae, IAstrocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Astrocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633503;

    /// <inheritdoc />
    public virtual string GenusName => "Astrocottus";

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
