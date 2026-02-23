using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Eulabeornis;

/// <summary>
/// Abstract class for Eulabeornis (genus).
/// NCBI TaxId: 1150653
/// </summary>
public abstract class Eulabeornis : Rallidae, IEulabeornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulabeornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150653;

    /// <inheritdoc />
    public virtual string GenusName => "Eulabeornis";

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
