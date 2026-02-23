using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Jabiru;

/// <summary>
/// Abstract class for Jabiru (genus).
/// NCBI TaxId: 33590
/// </summary>
public abstract class Jabiru : Ciconiidae, IJabiru
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jabiru";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33590;

    /// <inheritdoc />
    public virtual string GenusName => "Jabiru";

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
