using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Ostorhinchus;

/// <summary>
/// Abstract class for Ostorhinchus (genus).
/// NCBI TaxId: 638290
/// </summary>
public abstract class Ostorhinchus : Apogonidae, IOstorhinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ostorhinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 638290;

    /// <inheritdoc />
    public virtual string GenusName => "Ostorhinchus";

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
