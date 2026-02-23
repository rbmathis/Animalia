using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Eupsittula;

/// <summary>
/// Abstract class for Eupsittula (genus).
/// NCBI TaxId: 1548947
/// </summary>
public abstract class Eupsittula : Psittacidae, IEupsittula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupsittula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1548947;

    /// <inheritdoc />
    public virtual string GenusName => "Eupsittula";

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
