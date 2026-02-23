using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Enneacampus;

/// <summary>
/// Abstract class for Enneacampus (genus).
/// NCBI TaxId: 1073240
/// </summary>
public abstract class Enneacampus : Syngnathidae, IEnneacampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enneacampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1073240;

    /// <inheritdoc />
    public virtual string GenusName => "Enneacampus";

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
