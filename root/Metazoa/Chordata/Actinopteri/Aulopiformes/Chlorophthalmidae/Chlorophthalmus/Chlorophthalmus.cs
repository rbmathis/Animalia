using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Chlorophthalmidae.Chlorophthalmus;

/// <summary>
/// Abstract class for Chlorophthalmus (genus).
/// NCBI TaxId: 68512
/// </summary>
public abstract class Chlorophthalmus : Chlorophthalmidae, IChlorophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68512;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorophthalmus";

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
