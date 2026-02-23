using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Cibacapsa;

/// <summary>
/// Abstract class for Cibacapsa (genus).
/// NCBI TaxId: 3475073
/// </summary>
public abstract class Cibacapsa : Octacnemidae, ICibacapsa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cibacapsa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3475073;

    /// <inheritdoc />
    public virtual string GenusName => "Cibacapsa";

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
