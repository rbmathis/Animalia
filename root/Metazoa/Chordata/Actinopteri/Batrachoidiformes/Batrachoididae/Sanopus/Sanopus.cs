using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Sanopus;

/// <summary>
/// Abstract class for Sanopus (genus).
/// NCBI TaxId: 1182857
/// </summary>
public abstract class Sanopus : Batrachoididae, ISanopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sanopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182857;

    /// <inheritdoc />
    public virtual string GenusName => "Sanopus";

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
