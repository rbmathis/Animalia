using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Bascanichthys;

/// <summary>
/// Abstract class for Bascanichthys (genus).
/// NCBI TaxId: 2013004
/// </summary>
public abstract class Bascanichthys : Ophichthidae, IBascanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bascanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2013004;

    /// <inheritdoc />
    public virtual string GenusName => "Bascanichthys";

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
