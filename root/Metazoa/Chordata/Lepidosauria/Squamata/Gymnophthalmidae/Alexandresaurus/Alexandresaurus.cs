using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Alexandresaurus;

/// <summary>
/// Abstract class for Alexandresaurus (genus).
/// NCBI TaxId: 1235867
/// </summary>
public abstract class Alexandresaurus : Gymnophthalmidae, IAlexandresaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alexandresaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1235867;

    /// <inheritdoc />
    public virtual string GenusName => "Alexandresaurus";

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
