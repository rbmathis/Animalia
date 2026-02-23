using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Chacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Chacidae.Chaca;

/// <summary>
/// Abstract class for Chaca (genus).
/// NCBI TaxId: 61313
/// </summary>
public abstract class Chaca : Chacidae, IChaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61313;

    /// <inheritdoc />
    public virtual string GenusName => "Chaca";

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
