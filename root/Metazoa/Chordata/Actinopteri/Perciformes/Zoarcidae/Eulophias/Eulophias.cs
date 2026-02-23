using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Eulophias;

/// <summary>
/// Abstract class for Eulophias (genus).
/// NCBI TaxId: 1095901
/// </summary>
public abstract class Eulophias : Zoarcidae, IEulophias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulophias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1095901;

    /// <inheritdoc />
    public virtual string GenusName => "Eulophias";

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
