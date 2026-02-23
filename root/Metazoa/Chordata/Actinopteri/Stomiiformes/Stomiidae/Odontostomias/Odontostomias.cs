using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Odontostomias;

/// <summary>
/// Abstract class for Odontostomias (genus).
/// NCBI TaxId: 882847
/// </summary>
public abstract class Odontostomias : Stomiidae, IOdontostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882847;

    /// <inheritdoc />
    public virtual string GenusName => "Odontostomias";

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
