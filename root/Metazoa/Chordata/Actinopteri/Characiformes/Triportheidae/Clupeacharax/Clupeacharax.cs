using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae.Clupeacharax;

/// <summary>
/// Abstract class for Clupeacharax (genus).
/// NCBI TaxId: 930309
/// </summary>
public abstract class Clupeacharax : Triportheidae, IClupeacharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupeacharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930309;

    /// <inheritdoc />
    public virtual string GenusName => "Clupeacharax";

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
