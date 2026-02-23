using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Loxopholis;

/// <summary>
/// Abstract class for Loxopholis (genus).
/// NCBI TaxId: 2026623
/// </summary>
public abstract class Loxopholis : Gymnophthalmidae, ILoxopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2026623;

    /// <inheritdoc />
    public virtual string GenusName => "Loxopholis";

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
