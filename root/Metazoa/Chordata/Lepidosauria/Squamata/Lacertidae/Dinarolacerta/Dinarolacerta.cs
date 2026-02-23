using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Dinarolacerta;

/// <summary>
/// Abstract class for Dinarolacerta (genus).
/// NCBI TaxId: 481552
/// </summary>
public abstract class Dinarolacerta : Lacertidae, IDinarolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinarolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 481552;

    /// <inheritdoc />
    public virtual string GenusName => "Dinarolacerta";

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
