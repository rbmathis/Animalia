using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Alopoglossus;

/// <summary>
/// Abstract class for Alopoglossus (genus).
/// NCBI TaxId: 174732
/// </summary>
public abstract class Alopoglossus : Gymnophthalmidae, IAlopoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alopoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174732;

    /// <inheritdoc />
    public virtual string GenusName => "Alopoglossus";

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
