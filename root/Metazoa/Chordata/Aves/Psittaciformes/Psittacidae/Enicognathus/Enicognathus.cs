using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Enicognathus;

/// <summary>
/// Abstract class for Enicognathus (genus).
/// NCBI TaxId: 345189
/// </summary>
public abstract class Enicognathus : Psittacidae, IEnicognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enicognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 345189;

    /// <inheritdoc />
    public virtual string GenusName => "Enicognathus";

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
