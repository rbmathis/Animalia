using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Martes;

/// <summary>
/// Abstract class for Martes (genus).
/// NCBI TaxId: 9658
/// </summary>
public abstract class Martes : Mustelidae, IMartes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Martes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9658;

    /// <inheritdoc />
    public virtual string GenusName => "Martes";

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
