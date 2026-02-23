using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys;

/// <summary>
/// Abstract class for Mesoclemmys (genus).
/// NCBI TaxId: 571339
/// </summary>
public abstract class Mesoclemmys : Chelidae, IMesoclemmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesoclemmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 571339;

    /// <inheritdoc />
    public virtual string GenusName => "Mesoclemmys";

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
