using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Osteogaster;

/// <summary>
/// Abstract class for Osteogaster (genus).
/// NCBI TaxId: 3162714
/// </summary>
public abstract class Osteogaster : Callichthyidae, IOsteogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3162714;

    /// <inheritdoc />
    public virtual string GenusName => "Osteogaster";

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
