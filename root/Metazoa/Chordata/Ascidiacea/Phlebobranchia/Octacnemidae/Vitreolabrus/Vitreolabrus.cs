using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Vitreolabrus;

/// <summary>
/// Abstract class for Vitreolabrus (genus).
/// NCBI TaxId: 3680928
/// </summary>
public abstract class Vitreolabrus : Octacnemidae, IVitreolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vitreolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680928;

    /// <inheritdoc />
    public virtual string GenusName => "Vitreolabrus";

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
