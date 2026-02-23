using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Gymnophthalmus;

/// <summary>
/// Abstract class for Gymnophthalmus (genus).
/// NCBI TaxId: 88857
/// </summary>
public abstract class Gymnophthalmus : Gymnophthalmidae, IGymnophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88857;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnophthalmus";

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
