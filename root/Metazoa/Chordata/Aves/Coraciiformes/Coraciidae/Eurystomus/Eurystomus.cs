using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Eurystomus;

/// <summary>
/// Abstract class for Eurystomus (genus).
/// NCBI TaxId: 188339
/// </summary>
public abstract class Eurystomus : Coraciidae, IEurystomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurystomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188339;

    /// <inheritdoc />
    public virtual string GenusName => "Eurystomus";

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
