using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Graydidascalus;

/// <summary>
/// Abstract class for Graydidascalus (genus).
/// NCBI TaxId: 244086
/// </summary>
public abstract class Graydidascalus : Psittacidae, IGraydidascalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graydidascalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 244086;

    /// <inheritdoc />
    public virtual string GenusName => "Graydidascalus";

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
