using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Sparus;

/// <summary>
/// Abstract class for Sparus (genus).
/// NCBI TaxId: 8174
/// </summary>
public abstract class Sparus : Sparidae, ISparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8174;

    /// <inheritdoc />
    public virtual string GenusName => "Sparus";

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
