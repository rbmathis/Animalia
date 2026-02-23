using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Papasula;

/// <summary>
/// Abstract class for Papasula (genus).
/// NCBI TaxId: 57659
/// </summary>
public abstract class Papasula : Sulidae, IPapasula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papasula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57659;

    /// <inheritdoc />
    public virtual string GenusName => "Papasula";

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
