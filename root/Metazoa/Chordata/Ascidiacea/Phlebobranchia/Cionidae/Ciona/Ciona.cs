using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Cionidae.Ciona;

/// <summary>
/// Abstract class for Ciona (genus).
/// NCBI TaxId: 7718
/// </summary>
public abstract class Ciona : Cionidae, ICiona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ciona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7718;

    /// <inheritdoc />
    public virtual string GenusName => "Ciona";

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
