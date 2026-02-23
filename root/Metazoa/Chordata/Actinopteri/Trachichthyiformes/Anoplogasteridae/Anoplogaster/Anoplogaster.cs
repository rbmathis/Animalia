using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anoplogasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anoplogasteridae.Anoplogaster;

/// <summary>
/// Abstract class for Anoplogaster (genus).
/// NCBI TaxId: 88655
/// </summary>
public abstract class Anoplogaster : Anoplogasteridae, IAnoplogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoplogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88655;

    /// <inheritdoc />
    public virtual string GenusName => "Anoplogaster";

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
