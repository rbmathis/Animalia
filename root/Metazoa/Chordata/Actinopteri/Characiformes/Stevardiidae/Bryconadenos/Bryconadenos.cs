using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Bryconadenos;

/// <summary>
/// Abstract class for Bryconadenos (genus).
/// NCBI TaxId: 681904
/// </summary>
public abstract class Bryconadenos : Stevardiidae, IBryconadenos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryconadenos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681904;

    /// <inheritdoc />
    public virtual string GenusName => "Bryconadenos";

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
