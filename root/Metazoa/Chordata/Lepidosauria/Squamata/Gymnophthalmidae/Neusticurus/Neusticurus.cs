using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Neusticurus;

/// <summary>
/// Abstract class for Neusticurus (genus).
/// NCBI TaxId: 122287
/// </summary>
public abstract class Neusticurus : Gymnophthalmidae, INeusticurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neusticurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 122287;

    /// <inheritdoc />
    public virtual string GenusName => "Neusticurus";

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
