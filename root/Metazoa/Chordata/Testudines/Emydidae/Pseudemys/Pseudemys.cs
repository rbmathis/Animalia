using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Pseudemys;

/// <summary>
/// Abstract class for Pseudemys (genus).
/// NCBI TaxId: 270251
/// </summary>
public abstract class Pseudemys : Emydidae, IPseudemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270251;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudemys";

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
