using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Histiogamphelus;

/// <summary>
/// Abstract class for Histiogamphelus (genus).
/// NCBI TaxId: 1914721
/// </summary>
public abstract class Histiogamphelus : Syngnathidae, IHistiogamphelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histiogamphelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914721;

    /// <inheritdoc />
    public virtual string GenusName => "Histiogamphelus";

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
