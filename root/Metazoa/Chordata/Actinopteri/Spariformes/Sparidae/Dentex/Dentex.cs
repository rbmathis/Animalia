using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Dentex;

/// <summary>
/// Abstract class for Dentex (genus).
/// NCBI TaxId: 94950
/// </summary>
public abstract class Dentex : Sparidae, IDentex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dentex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94950;

    /// <inheritdoc />
    public virtual string GenusName => "Dentex";

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
