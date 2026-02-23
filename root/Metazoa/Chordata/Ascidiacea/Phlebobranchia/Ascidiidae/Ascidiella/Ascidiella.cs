using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidiella;

/// <summary>
/// Abstract class for Ascidiella (genus).
/// NCBI TaxId: 201960
/// </summary>
public abstract class Ascidiella : Ascidiidae, IAscidiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ascidiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201960;

    /// <inheritdoc />
    public virtual string GenusName => "Ascidiella";

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
