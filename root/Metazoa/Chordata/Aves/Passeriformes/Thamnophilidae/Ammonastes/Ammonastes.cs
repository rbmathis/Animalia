using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Ammonastes;

/// <summary>
/// Abstract class for Ammonastes (genus).
/// NCBI TaxId: 2767393
/// </summary>
public abstract class Ammonastes : Thamnophilidae, IAmmonastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammonastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767393;

    /// <inheritdoc />
    public virtual string GenusName => "Ammonastes";

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
