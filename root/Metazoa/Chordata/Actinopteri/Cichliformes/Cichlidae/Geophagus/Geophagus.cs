using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Geophagus;

/// <summary>
/// Abstract class for Geophagus (genus).
/// NCBI TaxId: 13073
/// </summary>
public abstract class Geophagus : Cichlidae, IGeophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13073;

    /// <inheritdoc />
    public virtual string GenusName => "Geophagus";

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
