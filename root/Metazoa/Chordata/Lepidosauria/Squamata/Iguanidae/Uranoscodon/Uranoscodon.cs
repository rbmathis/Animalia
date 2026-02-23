using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Uranoscodon;

/// <summary>
/// Abstract class for Uranoscodon (genus).
/// NCBI TaxId: 44143
/// </summary>
public abstract class Uranoscodon : Iguanidae, IUranoscodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uranoscodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44143;

    /// <inheritdoc />
    public virtual string GenusName => "Uranoscodon";

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
