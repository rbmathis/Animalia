using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Zanclostomus;

/// <summary>
/// Abstract class for Zanclostomus (genus).
/// NCBI TaxId: 3054342
/// </summary>
public abstract class Zanclostomus : Cuculidae, IZanclostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zanclostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3054342;

    /// <inheritdoc />
    public virtual string GenusName => "Zanclostomus";

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
