using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Deroptyus;

/// <summary>
/// Abstract class for Deroptyus (genus).
/// NCBI TaxId: 51903
/// </summary>
public abstract class Deroptyus : Psittacidae, IDeroptyus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deroptyus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51903;

    /// <inheritdoc />
    public virtual string GenusName => "Deroptyus";

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
