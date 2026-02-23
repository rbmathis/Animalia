using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconamericus;

/// <summary>
/// Abstract class for Bryconamericus (genus).
/// NCBI TaxId: 171555
/// </summary>
public abstract class Bryconamericus : Stevardiidae, IBryconamericus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconamericus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 171555;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconamericus";

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
